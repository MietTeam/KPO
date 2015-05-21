using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using project;

namespace project
{
    [TestClass]
    public class UnitTestAuthorisation
    {
        authorisation testAuthorisation = new authorisation();
       
        [TestMethod]
        public void checkLoginPass()
        {
            testAuthorisation.setLoginPass("неверный логин","неверный пароль");
            Assert.IsFalse( testAuthorisation.CheckAccess());
        }
        [TestMethod]
        public void signIn()
        {
            testAuthorisation.setLoginPass("admin", "admin");
            Assert.IsTrue(testAuthorisation.CheckAccess());
        }
    }

    [TestClass]
    public class UnitTestMain
    {
        public User createUser()
        {
            User testUser = new User();
            testUser.id = 1;
            testUser.isAdmin = true;
            testUser.login = "admin";
            testUser.password = "admin";
            return testUser;
        }
        [TestMethod]
        public void TestRefresh()
        {
            main testMainForm = new main(createUser());
            Assert.IsFalse(testMainForm.PushButtons());
        }

        [TestMethod]
        public void todayEventFormVisible()
        {
            main testMainForm = new main(createUser());
            Assert.IsTrue(testMainForm.todayEventsVisible());
        }

    }

    [TestClass]
    public class UnitTestNewEvent
    {
        public User createUser()
        {
            User testUser = new User();
            testUser.id = 1;
            testUser.isAdmin = true;
            testUser.login = "admin";
            testUser.password = "admin";
            return testUser;
        }

        [TestMethod]
        public void TestClear()
        {
            main testMain = new main(createUser());
            NewEvent testNewEvent = new NewEvent(testMain, createUser());
            testNewEvent.setTitle("title");
            testNewEvent.setDescription("description");
            testNewEvent.buttonClear_Click(null,null);
            Assert.IsTrue(testNewEvent.getTitle() == "" && testNewEvent.getDescription() == "");
        }

        [TestMethod]
        public void TestSend()
        {
            main testMain = new main(createUser());
            NewEvent testNewEvent = new NewEvent(testMain, createUser());

            testNewEvent.fillForm("title", "description");
            testNewEvent.buttonSend_Click(null, null);
            testMain.buttonUpdate_Click(null, null);
            Assert.AreEqual("title", testMain.getLastEvent()[0]);
            Assert.AreEqual("description", testMain.getLastEvent()[1]);
            testMain.deleteTestEvent();
        }

        [TestMethod]
        public void fillForm()
        {
            main testMain = new main(createUser());
            NewEvent testNewEvent = new NewEvent(testMain, createUser());

            testNewEvent.fillForm("title", "description");
            Assert.AreSame("title", testNewEvent.getTitle());
            Assert.AreSame("Тип А", testNewEvent.getType());
            Assert.AreSame("Средний", testNewEvent.getPriority());
        }

        [TestMethod]
        public void buttonBack()
        {
            main testMain = new main(createUser());
            NewEvent testNewEvent = new NewEvent(testMain, createUser());
            testNewEvent.buttonBack_Click(null, null);
            Assert.IsTrue(testNewEvent.isMainVisible());
        }
    }
}
