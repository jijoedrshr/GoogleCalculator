using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace EbayXamarinTest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="platform"></param>
        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        [Category ("testone")]
        public void Test1_AdditionTest()
        {
            //AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            //app.Screenshot("Welcome screen.");
            
            app.Tap(x => x.Marked("menu_add_task"));
            app.EnterText(x => x.Marked("txtName"), "testjijo");
            app.Tap(x => x.Marked("menu_save_task"));
            app.WaitForElement("testjijo");
            app.Screenshot("Final Screen.");
            // app.Repl();
            /* app.WaitForElement(c => c.Id("digit_7"));
             app.Tap(c => c.Id("digit_7"));

             app.WaitForElement(c => c.Id("op_add"));
             app.Tap(c => c.Id("op_add"));

             app.WaitForElement(c => c.Id("digit_8"));
             app.Tap(c => c.Id("digit_8"));

             //int AddVal = Convert.ToInt32(c => c.Id("result_preview"));
            Object txtResult = app.Query(x => x.Id("result_preview").Invoke("getText"));
             Assert.AreEqual(((object[])txtResult)[0], "15"); */
        }

        [Test]
        public void Test2_SubtractionTest()
        {
            //AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            // app.Screenshot("Welcome screen.");
            // app.Repl();
            app.WaitForElement(c => c.Id("digit_9"));
            app.Tap(c => c.Id("digit_9"));

            app.WaitForElement(c => c.Id("op_sub"));
            app.Tap(c => c.Id("op_sub"));

            app.WaitForElement(c => c.Id("digit_6"));
            app.Tap(c => c.Id("digit_6"));

            //int AddVal = Convert.ToInt32(c => c.Id("result_preview"));
            Object txtResult = app.Query(x => x.Id("result_preview").Invoke("getText"));
            Assert.AreEqual(((object[])txtResult)[0], "3");
        }


        [Test]
        public void Test3_MultiplicationTest()
        {
            //AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            // app.Screenshot("Welcome screen.");
            // app.Repl();
            app.WaitForElement(c => c.Id("digit_5"));
            app.Tap(c => c.Id("digit_5"));

            app.WaitForElement(c => c.Id("op_mul"));
            app.Tap(c => c.Id("op_mul"));

            app.WaitForElement(c => c.Id("digit_6"));
            app.Tap(c => c.Id("digit_6"));

            //int AddVal = Convert.ToInt32(c => c.Id("result_preview"));
            Object txtResult = app.Query(x => x.Id("result_preview").Invoke("getText"));
            Assert.AreEqual(((object[])txtResult)[0], "30");
        }

        [Test]
        public void Test4_DivisionTest()
        {
            //AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            // app.Screenshot("Welcome screen.");
            // app.Repl();
            app.WaitForElement(c => c.Id("digit_4"));
            app.Tap(c => c.Id("digit_4"));

            app.WaitForElement(c => c.Id("op_div"));
            app.Tap(c => c.Id("op_div"));

            app.WaitForElement(c => c.Id("digit_2"));
            app.Tap(c => c.Id("digit_2"));

            //int AddVal = Convert.ToInt32(c => c.Id("result_preview"));
            Object txtResult = app.Query(x => x.Id("result_preview").Invoke("getText"));
            Assert.AreEqual(((object[])txtResult)[0], "2");
        }

        [Test]
        public void Test5_SquareRoot()
        {
            //AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            // app.Screenshot("Welcome screen.");
            // app.Repl();
            app.WaitForElement(c => c.Id("arrow"));
            app.Tap(c => c.Id("arrow"));

            app.WaitForElement(c => c.Id("op_sqrt"));
            app.Tap(c => c.Id("op_sqrt"));

            app.WaitForElement(c => c.Id("arrow"));
            app.Tap(c => c.Id("arrow"));

            app.WaitForElement(c => c.Id("digit_4"));
            app.Tap(c => c.Id("digit_4"));

            Object txtResult = app.Query(x => x.Id("result_preview").Invoke("getText"));
            Assert.AreEqual(((object[])txtResult)[0], "2");
        }

        [Test]
        public void Test6_SineTheta()
        {
            //AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            // app.Screenshot("Welcome screen.");
            // app.Repl();
            app.WaitForElement(c => c.Id("arrow"));
            app.Tap(c => c.Id("arrow"));

            app.WaitForElement(c => c.Id("fun_sin"));
            app.Tap(c => c.Id("fun_sin"));

            app.WaitForElement(c => c.Id("arrow"));
            app.Tap(c => c.Id("arrow"));

            app.WaitForElement(c => c.Id("digit_3"));
            app.Tap(c => c.Id("digit_3"));

            app.WaitForElement(c => c.Id("digit_0"));
            app.Tap(c => c.Id("digit_0"));

            Object txtResult = app.Query(x => x.Id("result_preview").Invoke("getText"));
            Assert.AreEqual(((object[])txtResult)[0], "0.5");
        }
    }
}
