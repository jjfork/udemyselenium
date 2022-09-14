//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

//class EntryPoint
//{
//    static IWebDriver driver = new ChromeDriver();
//    static IWebElement textBox;


//    static void Main()
//    {

//        string x = "Test text";
//        string url = "https://testing.todorvachev.com/text-input-field/";


//        driver.Navigate().GoToUrl(url);

//        textBox = driver.FindElement(By.Name("username"));

//        textBox.SendKeys(x);

//        Thread.Sleep(3000);

//        Console.WriteLine(textBox.GetAttribute("value"));

//        Thread.Sleep(3000);

//        driver.Quit();

//    }


//}
