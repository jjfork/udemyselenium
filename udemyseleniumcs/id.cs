//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

//// class id
//{
//    static void Main()
//    {

//        string url = "https://testing.todorvachev.com/id/";
//        string ID = "testImage";

//        IWebDriver driver = new ChromeDriver();

//        driver.Navigate().GoToUrl(url);

//        IWebElement element = driver.FindElement(By.Id(ID));

//        if (element.Displayed)
//        {
//            GreenMessage("Yes! I can see");
//        }
//        else
//        {
//            RedMessage("I can't see :c");
//        }
//        driver.Quit();
//    }

//    private static void RedMessage(string message)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine(message);
//        Console.ForegroundColor = ConsoleColor.White;
//    }

//    private static void GreenMessage(string message)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine(message);
//        Console.ForegroundColor = ConsoleColor.White;
//    }
//}