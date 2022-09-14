//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

//class EntryPoint
//{
//    static IWebDriver driver = new ChromeDriver();
//    static IWebElement checkBox;


//    static void Main()
//    {

//        string url = "https://testing.todorvachev.com/check-button-test-3/";
//        string option = "1";


//        driver.Navigate().GoToUrl(url);

//        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + option + ")"));

//        checkBox.Click();

//        Thread.Sleep(3000);

//        //if (checkBox.GetAttribute("checked") == "true")
//        //{
//        //    Console.WriteLine("checked!");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("not checked!");

//        driver.Quit();

//    }


//}
