//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

//class EntryPoint
//{
//    static void Main()
//    {

//        string url = "https://testing.todorvachev.com/css-path/";
//        string cssPath = "#post-108 > div > fure > img";
//        string xPath = "//*[@id=\"post-108\"]/div/figure/img";


//        IWebDriver driver = new ChromeDriver();

//        driver.Navigate().GoToUrl(url);

//        IWebElement cssPathElement;
//        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

//        try
//        {
//            cssPathElement = driver.FindElement(By.CssSelector(cssPath));
//            if (cssPathElement.Displayed)
//            {
//                GreenMessage("I can see css path!");
//            }

//        }
//        catch (NoSuchElementException)
//        {
//            RedMessage("I can't see the css path!");
//        }


//        if (xPathElement.Displayed)
//        {
//            GreenMessage("I can see xpath!");
//        }
//        else
//        {
//            RedMessage("I cant see xpath");
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