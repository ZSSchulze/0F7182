using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using OpenQA.Selenium.Interactions;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml;

namespace _0F7182
{
    public partial class mainForm : Form
    {
        Functions fClass = new Functions();

        [DllImport("User32")]
        private static extern int ShowWindow(IntPtr hwnd, int nCmdShow);

        IWebDriver driver = null;
        List<string[]> internalDB = new List<string[]>();
        List<string[]> accountOverviews = new List<string[]>();
        Dictionary<string[], List<string[]>> completedAccounts = new Dictionary<string[], List<string[]>>();
        string setPrefs;

        public mainForm()
        {
            InitializeComponent();
            string[] coins = { "995", "Coins", "1" };
            internalDB.Add(coins);

            setPrefs = $"{Directory.GetCurrentDirectory()}\\ChromePrefs";

            if (!Directory.Exists(setPrefs))
            {
                importAccountsToolStripMenuItem.Enabled = false;
                tabControl1.Enabled = false;
                MessageBox.Show("Select 'Set Prefs' from menu before running checks.", "Startup Requirements");
            }

        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (fClass.IsDigitsOnly(tbItemID.Text) && !listCustomItems.Items.Contains(tbItemID.Text) && !String.IsNullOrEmpty(tbItemID.Text))
                listCustomItems.Items.Add(tbItemID.Text);
            else if (!fClass.IsDigitsOnly(tbItemID.Text))
                MessageBox.Show("Item ID is invalid", "Error");
            else if (listCustomItems.Items.Contains(tbItemID.Text))
                MessageBox.Show("Item ID already in list", "Error");

            tbItemID.Clear();
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            listCustomItems.Items.Remove(listCustomItems.Items[listCustomItems.SelectedIndex]);
        }

        private void importAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAccounts = new OpenFileDialog();
            if (ofdAccounts.ShowDialog() == DialogResult.OK)
            {
                List<string[]> rows = File.ReadAllLines(ofdAccounts.FileName).Select(x => x.Split(':')).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Username");
                dt.Columns.Add("Password");
                rows.ForEach(x => {
                    dt.Rows.Add(x);
                });
                dgvAccounts.DataSource = dt;
            }
        }

        private void buttonSaveConfigs_Click(object sender, EventArgs e)
        {
            
        }

        public void beginChecks()
        {
            progressBar.Maximum = dgvAccounts.Rows.Count - 1;
            Task.Run(() =>
            {
                ParallelOptions options = new ParallelOptions();
                options.MaxDegreeOfParallelism = (int)(1);
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                var driverOptions = new ChromeOptions();
                driverOptions.AddArgument("--headless");
                driverOptions.AddArgument($"user-data-dir={setPrefs}");
                driver = new ChromeDriver(driverService, driverOptions);
                driver.Manage().Window.Size = new Size(887, 558);
                driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                string title = String.Format("{0} - Google Chrome", driver.Title);
                var process = Process.GetProcesses()
                    .FirstOrDefault(x => x.MainWindowTitle == title);
                ShowWindow(process.MainWindowHandle, 0);

                Parallel.ForEach(dgvAccounts.Rows.Cast<DataGridViewRow>(), options, (account) =>
                {
                    if (account.IsNewRow)
                        return;

                    Invoke(new MethodInvoker(
                        () => progressBar.Increment(1)));

                    Invoke(new MethodInvoker(
                                    () => rtbDebugLog.AppendText($"{fClass.logTime()} : Starting Debug For New Account." + Environment.NewLine)
                                ));

                    var Username = account.Cells[0].Value.ToString();
                    var Password = account.Cells[1].Value.ToString();
                    string rsIGN = "null";
                    string rsMP = "0";
                    int bankTabCount = 0;
                    WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                    WebDriverWait wait15 = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                    //Login To RS Companion
                    try
                    {
                        IWebElement element = wait15.Until(ExpectedConditions.ElementIsVisible(By.Id("username")));
                        element.SendKeys(Username);
                        element = wait3.Until(ExpectedConditions.ElementIsVisible(By.Id("password")));
                        element.SendKeys(Password);
                        element.SendKeys(OpenQA.Selenium.Keys.Enter);

                        Invoke(new MethodInvoker(
                                    () => rtbConsoleLog.AppendText($"{fClass.logTime()} : Attempting to login with {Username} using password {Password}" + Environment.NewLine)
                                ));
                    }
                    catch (WebDriverTimeoutException te)
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbDebugLog.AppendText($"{fClass.logTime()} : Error: WebDriver Timeout Exception.  {te}" + Environment.NewLine)
                                ));
                        driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");//driver.Quit(); //driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                        return;
                    }
                    catch (WebDriverException ex)
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbDebugLog.AppendText($"{fClass.logTime()} : Error: WebDriver Exception Triggered. {ex}" + Environment.NewLine)
                                ));
                        driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");//driver.Quit(); //driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                        return;
                    }
                    finally
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbConsoleLog.AppendText($"{fClass.logTime()} : Success: Loaded in login information." + Environment.NewLine)
                                ));
                    }
                    //Do Not Ask/Failed Login/Authenticator?
                    try
                    {
                        IWebElement element = wait3.Until(
                            ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"modal\"]/div/div"))
                        );

                        string loginResult = element.GetAttribute("ng-include");

                        if (loginResult == "\'partials/login_error.ws\'")
                        {
                            Invoke(new MethodInvoker(
                                    () => rtbConsoleLog.AppendText($"{fClass.logTime()} : Error: Login Failed. (Invalid Password || User has current session)" + Environment.NewLine)
                                ));
                            driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");//driver.Quit(); //driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                            return;
                        }
                        else if (loginResult == "\'partials/login_pin.ws\'")
                        {
                            Invoke(new MethodInvoker(
                                    () => rtbConsoleLog.AppendText($"{fClass.logTime()} : Error: Login Succeeded. RuneScape Authenticator Detected" + Environment.NewLine)
                                ));
                            driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");//driver.Quit(); //driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                            return;
                        }
                    }
                    catch (WebDriverTimeoutException te)
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbConsoleLog.AppendText($"{fClass.logTime()} : Success: Login Succeeded. Moving onto do not ask." + Environment.NewLine)
                                ));
                    }
                    catch (WebDriverException ex)
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbDebugLog.AppendText($"{fClass.logTime()} : Error: WebDriver Exception Triggered. {ex}" + Environment.NewLine)
                                ));
                        driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");//driver.Quit(); //driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                        return;
                    }
                    //Answer Do Not Ask
                    try
                    {
                        IWebElement element = wait3.Until(
                            ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"modal\"]/div/div/div/div[1]/a[1]"))
                        );
                        element.Click();
                        Invoke(new MethodInvoker(
                                   () => rtbConsoleLog.AppendText($"{fClass.logTime()} : Success: Found Do not ask Dialog. Moving to next step." + Environment.NewLine)
                               ));
                    }
                    catch (WebDriverTimeoutException te)
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbDebugLog.AppendText($"{fClass.logTime()} : Error: WebDriver Exception Triggered. {te}" + Environment.NewLine)
                                ));
                        driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");//driver.Quit(); //driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                        return;
                    }
                    catch (WebDriverException ex)
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbDebugLog.AppendText($"{fClass.logTime()} : Error: WebDriver Exception Triggered. {ex}" + Environment.NewLine)
                                ));
                        driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");//driver.Quit(); //driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                        return;
                    }
                    //Select Bank Tab
                    try
                    {
                        IWebElement element = wait3.Until(
                            ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main-menu\"]/div/nav/ul/li[2]/a"))
                        );
                        rsIGN = (driver.FindElement(By.XPath("//*[@id=\"main-menu\"]/header/a")).Text).ToString();
                        element.Click();
                        Invoke(new MethodInvoker(
                                   () => rtbConsoleLog.AppendText($"{fClass.logTime()} : RuneScape in game name retrieved as {rsIGN}." + Environment.NewLine)
                               ));
                        Invoke(new MethodInvoker(
                                    () => rtbConsoleLog.AppendText($"{fClass.logTime()} : Successfully selected bank tab." + Environment.NewLine)
                                ));
                    }
                    catch (WebDriverTimeoutException te)
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbDebugLog.AppendText($"{fClass.logTime()} : Error: WebDriver Timeout Exception.  {te}" + Environment.NewLine)
                                ));
                        driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");//driver.Quit(); //driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                        return;
                    }
                    catch (WebDriverException ex)
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbDebugLog.AppendText($"{fClass.logTime()} : Error: WebDriver Exception Triggered. {ex}" + Environment.NewLine)
                                ));
                        driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");//driver.Quit(); //driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                        return;
                    }
                    /*finally
                    {
                        
                    }*/
                    //Account has bank pin?
                    try
                    {
                        IWebElement element = wait3.Until(
                            ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"bank-pinpad\"]'"))
                        );
                        Invoke(new MethodInvoker(
                                    () => rtbConsoleLog.AppendText($"{fClass.logTime()} : Error: Bank pin has been found on the account." + Environment.NewLine)
                                ));
                        driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");//driver.Quit(); //driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                    }
                    catch (WebDriverTimeoutException te)
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbConsoleLog.AppendText($"{fClass.logTime()} : Success: No bank pin on account" + Environment.NewLine)
                                ));
                    }
                    catch (WebDriverException ex)
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbDebugLog.AppendText($"{fClass.logTime()} : Error: WebDriver Exception Triggered. {ex}" + Environment.NewLine)
                                ));
                        //driver.Quit();
                        return;
                    }
                    //Count Total Bank Tabs
                    try
                    {
                        IWebElement element = wait3.Until(
                            ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/div[1]/section/footer/div[2]/select/option"))
                            );

                        bankTabCount = (driver.FindElements(By.XPath("/html/body/div[3]/div[1]/section/footer/div[2]/select/option")).ToArray()).Length;
                        Invoke(new MethodInvoker(
                                    () => rtbConsoleLog.AppendText($"{fClass.logTime()} : Success: {bankTabCount} Bank tabs have been detected" + Environment.NewLine)
                                ));
                        Invoke(new MethodInvoker(
                                    () => rtbConsoleLog.AppendText($"{fClass.logTime()} : Moving to next step" + Environment.NewLine)
                                ));
                    }
                    catch (WebDriverTimeoutException te)
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbDebugLog.AppendText($"{fClass.logTime()} : Error: WebDriver Timeout Exception.  {te}" + Environment.NewLine)
                                ));
                        driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");//driver.Quit(); //driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                        return;
                    }
                    catch (WebDriverException ex)
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbDebugLog.AppendText(string.Format("{0} : Error: WebDriver Exception Triggered. {1}", fClass.logTime(), ex) + Environment.NewLine)
                                ));
                        driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");//driver.Quit(); //driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                        return;
                    }
                    //Begin Item Lookup
                    try
                    {
                        int accountValue = 0;
                        string[] currentItems = new string[] { };
                        List<string[]> allItems = new List<string[]>();

                        
                        int counter = 0;
                        while (counter < bankTabCount)
                        {
                            counter++;

                            var tabItems = driver.FindElements(By.XPath("//*[@id=\"bank-list\"]/ul/li/a/img"));

                            foreach (IWebElement item in tabItems)
                            {
                                Regex regexItemInfo = new Regex("gif\\?id=(\\d+)&count=(\\d+)");
                                Match matchedInfo = regexItemInfo.Match(item.GetAttribute("ng-src"));
                                int getItemID = 0;
                                int getItemCount = 0;
                                string itemName = "Error";
                                int itemPrice = 0;

                                if (matchedInfo.Groups.Count > 1)
                                {
                                    getItemID = Convert.ToInt32(matchedInfo.Groups[1].Value);
                                    getItemCount = Convert.ToInt32(matchedInfo.Groups[2].Value);
                                }

                                List<string> inDB = new List<string>();

                                foreach (var itemSet in internalDB)
                                {
                                    if (itemSet[0] == getItemID.ToString())
                                    {
                                        inDB.Add(itemSet[1]);
                                        inDB.Add(itemSet[2]);
                                        break;
                                    }
                                }

                                if (inDB.Count == 0)
                                {
                                    string[] retrievedInfo = fClass.retrieveItemInfo(getItemID);
                                    itemName = retrievedInfo[0];
                                    itemPrice = Convert.ToInt32(retrievedInfo[1].Replace(",", ""));

                                    string[] addToDB = new string[] { getItemID.ToString(), itemName, itemPrice.ToString() };

                                    internalDB.Add(addToDB);

                                }
                                else
                                {
                                    itemName = inDB[0];
                                    itemPrice = Convert.ToInt32(inDB[1]);
                                }
                                string customItem = "No";
                                if (listCustomItems.Items.Contains(getItemID.ToString()))
                                    customItem = "Yes";
                                currentItems = new string[] { customItem, getItemID.ToString(), itemName, itemPrice.ToString(), getItemCount.ToString(), (Convert.ToInt32(getItemCount) * Convert.ToInt32(itemPrice)).ToString() };
                                allItems.Add(currentItems);
                                Invoke(new MethodInvoker(
                                    () => rtbConsoleLog.AppendText($"{fClass.logTime()} : {itemName} : {itemPrice} : {Convert.ToInt32(getItemCount) * Convert.ToInt32(itemPrice)}" + Environment.NewLine)
                                ));
                                accountValue += (Convert.ToInt32(getItemCount) * Convert.ToInt32(itemPrice));
                            }
                            if (bankTabCount != 1)
                            {
                                driver.FindElement(By.XPath("/html/body/div[3]/div[1]/section/footer/div[4]/a/i")).Click();
                                wait3.Until(
                                    ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"bank-list\"]/ul/li/a/img")));
                            }
                        }
                        //Money Pouch Values
                        rsMP = driver.FindElement(By.XPath("/html/body/div[3]/div[1]/section/div[3]/span")).Text;
                        rsMP = rsMP.Replace("gp", "").Replace(" ", "");
                        if (String.IsNullOrEmpty(rsMP) || String.IsNullOrWhiteSpace(rsMP) || rsMP.Length == 0)
                            rsMP = "0";
                        Invoke(new MethodInvoker(
                                    () => rtbConsoleLog.AppendText($"{fClass.logTime()} : {rsMP} Total Gold Found in Money Pouch" + Environment.NewLine)
                                ));

                        string[] currentAccount = { };
                        currentAccount = new string[] { Username, Password, rsIGN, rsMP };

                        completedAccounts.Add(currentAccount, allItems);

                        Invoke(new MethodInvoker(
                                    () => dgvCAccounts.Rows.Add(Username)
                                ));

                        accountValue += Convert.ToInt32(rsMP.Replace(",", ""));

                        Invoke(new MethodInvoker(
                                    () =>  dgvOverview.Rows.Add(Username, Password, rsIGN, Convert.ToInt32(rsMP.Replace(",", "")), allItems.Count, accountValue)
                                ));
                        accountOverviews.Add(new string[] { Username, Password, rsIGN, rsMP.Replace(",", ""), allItems.Count.ToString(), accountValue.ToString() });
                        //ADD Completed ACCOUNT
                    }
                    catch (WebDriverTimeoutException te)
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbDebugLog.AppendText($"{fClass.logTime()} : Error: Timeout Exception Triggered. {te}" + Environment.NewLine)
                                ));
                        driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");//driver.Quit(); //driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                        return;
                    }
                    catch (WebDriverException ex)
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbDebugLog.AppendText($"{fClass.logTime()} : Error: WebDriver Exception Triggered. {ex}" + Environment.NewLine)
                                ));
                        driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");//driver.Quit(); //driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                        return;
                    }
                    //Logout
                    try
                    {
                        IWebElement element = wait3.Until(
                            ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"main-menu\"]/div/nav/ul/li[9]/a/span"))
                            );
                        element.Click();
                        element = wait3.Until(
                            ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"modal\"]/div/div/div/div/a[2]"))
                            );
                        element.Click();
                    }
                    catch (WebDriverTimeoutException te)
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbDebugLog.AppendText($"{fClass.logTime()} : Error: Timeout Exception Triggered. {te}" + Environment.NewLine)
                                ));
                        driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                        return;
                    }
                    catch (WebDriverException ex)
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbDebugLog.AppendText($"{fClass.logTime()} : Error: WebDriver Exception Triggered. {ex}" + Environment.NewLine)
                                ));
                        driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");
                        return;
                    }
                    finally
                    {
                        Invoke(new MethodInvoker(
                                    () => rtbConsoleLog.AppendText($"{fClass.logTime()} : Successful Logout" + Environment.NewLine)
                                ));
                        //driver.Quit();
                    }

                    
                });

                Invoke(new MethodInvoker(() => progressBar.Value = 0));
                Invoke(new MethodInvoker(() => buttonExecute.Enabled = true));
                Invoke(new MethodInvoker(() => buttonExportResults.Enabled = true));
                driver.Quit();
            });
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if(dgvAccounts.Rows.Count > 0)
            {
                beginChecks();
                buttonExecute.Enabled = false;
            } 
        }

        private void dgvCAccounts_SelectionChanged(object sender, EventArgs e)
        {
            if (!dgvCAccounts.CurrentRow.IsNewRow)
            {
                dgvADetails.Rows.Clear();
                dgvADetails.Refresh();
                foreach(var acc in completedAccounts)
                {
                    if(acc.Key[0] == dgvCAccounts.CurrentRow.Cells[0].Value.ToString())
                    {
                        int totalValue = 0;
                        int customItems = 0;
                        foreach(var item in acc.Value)
                        {
                            dgvADetails.Rows.Add(item[0], item[1], item[2], Convert.ToInt32(item[3]), Convert.ToInt32(item[4]), Convert.ToInt32(item[5]));
                            totalValue += Convert.ToInt32(item[5]);

                            if (item[0] == "Yes" && customItems == 0)
                                customItems = 1;
                        }
                        totalValue = totalValue + Convert.ToInt32(acc.Key[3].Replace(",", ""));

                        labelUN.Text = acc.Key[0];
                        labelIGN.Text = acc.Key[2];
                        labelMP.Text = acc.Key[3];
                        labelBI.Text = acc.Value.Count.ToString();
                        labelTV.Text = $"{totalValue:N0}";
                        if (customItems == 1)
                            labelCI.Text = "Yes";
                        else
                            labelCI.Text = "No";
                        break;
                    }
                }
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(driver != null)
            {
                driver.Quit();
            }
        }

        private void setPrefsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            var driverOptions = new ChromeOptions();
            driverOptions.AddArgument($"user-data-dir={setPrefs}");
            IWebDriver driver = new ChromeDriver(driverService, driverOptions);
            driver.Manage().Window.Size = new Size(887, 558);
            driver.Navigate().GoToUrl("http://services.runescape.com/m=world11/html5/comapp/");

            tabControl1.Enabled = true;
            importAccountsToolStripMenuItem.Enabled = true;
        }

        private void buttonExportOverview_Click(object sender, EventArgs e)
        {
            if (dgvOverview.Rows.Count == 0)
                return;
            SaveFileDialog sfdOverview = new SaveFileDialog();
            sfdOverview.Filter = "CSV Files | *.csv";
            sfdOverview.DefaultExt = "csv";
            if (sfdOverview.ShowDialog() == DialogResult.OK)
            {
                dgvOverview.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                dgvOverview.SelectAll();
                DataObject dataObject = dgvOverview.GetClipboardContent();
                File.WriteAllText(sfdOverview.FileName, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
            }
        }

        private void buttonClearOverview_Click(object sender, EventArgs e)
        {
            dgvOverview.Rows.Clear();
        }

        private void buttonGenOverview_Click(object sender, EventArgs e)
        {
            foreach(var account in accountOverviews)
            {
                dgvOverview.Rows.Add(account[0], account[1], account[2], Convert.ToInt32(account[3]), Convert.ToInt32(account[4]), Convert.ToInt32(account[5]));
            }
        }

        private void buttonExportResults_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdExportResults = new SaveFileDialog();
            sfdExportResults.Filter = "XML Files | *.xml";
            sfdExportResults.DefaultExt = ".xml";
            if (sfdExportResults.ShowDialog() == DialogResult.OK)
            {
                XElement ad = new XElement("Accounts");
                XElement elem = new XElement("Runescape", ad);

                foreach (var pair in completedAccounts)
                {
                    ad.Add(new XElement("AccountData",
                               new XElement("Username", pair.Key[0]),
                               new XElement("Password", pair.Key[1]),
                               new XElement("RunescapeName", pair.Key[2]),
                               new XElement("MoneyPouch", pair.Key[3]),
                               new XElement("Items", from item in pair.Value
                                                     select new XElement("Item",
                                                        new XElement("CustomItem", item[0]),
                                                        new XElement("ItemID", item[1]),
                                                        new XElement("ItemName", item[2]),
                                                        new XElement("ItemPrice", item[3]),
                                                        new XElement("Quantity", item[4]),
                                                        new XElement("Value", item[5])
                                             ))
                    ));
                }
                elem.Save(sfdExportResults.FileName);
            }
        }

        private void buttonImportResults_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImportResults = new OpenFileDialog();
            ofdImportResults.Filter = "XML Files | *.xml";
            ofdImportResults.DefaultExt = ".xml";

            if (ofdImportResults.ShowDialog() == DialogResult.OK)
            {
                XDocument xReader = XDocument.Load(ofdImportResults.FileName);

                foreach (var element in xReader.Root.Element("Accounts").Elements())
                {
                    string[] currentAccount = new string[] { element.Element("Username").Value.ToString(),
                                                         element.Element("Password").Value.ToString(),
                                                         element.Element("RunescapeName").Value.ToString(),
                                                          element.Element("MoneyPouch").Value.ToString()};

                    List<string[]> currentItems = new List<string[]>();
                    int itemCount = 0;
                    int totalValue = Convert.ToInt32(element.Element("MoneyPouch").Value.Replace(",", ""));
                    foreach (var item in element.Element("Items").Elements())
                    {
                        string[] addItem = { item.Element("CustomItem").Value.ToString(),
                                                      item.Element("ItemID").Value.ToString(),
                                                      item.Element("ItemName").Value.ToString(),
                                                      item.Element("ItemPrice").Value.ToString(),
                                                      item.Element("Quantity").Value.ToString(),
                                                      item.Element("Value").Value.ToString()};
                        totalValue += Convert.ToInt32(item.Element("Value").Value);
                        currentItems.Add(addItem);
                        itemCount++;
                    }
                    accountOverviews.Add(new string[] { element.Element("Username").Value.ToString(),
                                                    element.Element("Password").Value.ToString(),
                                                    element.Element("RunescapeName").Value.ToString(),
                                                    element.Element("MoneyPouch").Value.ToString().Replace(",", ""),
                                                    itemCount.ToString(),
                                                    totalValue.ToString()});
                    completedAccounts.Add(currentAccount, currentItems);
                    dgvCAccounts.Rows.Add(element.Element("Username").Value.ToString());

                }
            }
        }
    }
}
