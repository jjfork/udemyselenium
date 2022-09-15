using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IAlert alert;
    static IWebElement image;
    static void Main()
    {
        string url = "https://testing.todorvachev.com/alert-box/";

        driver.Navigate().GoToUrl(url);

        alert = driver.SwitchTo().Alert();

        Console.WriteLine(alert.Text);

        alert.Accept();

        image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));


        try
        {
            if (image.Displayed)
            {
                Console.WriteLine("ISEE!");
            }
        }
        catch (NoSuchElementException)
        {
            Console.WriteLine("IDONTSEEEEEEEE!");
        }

        Thread.Sleep(3000);

        driver.Quit();

    }


}
