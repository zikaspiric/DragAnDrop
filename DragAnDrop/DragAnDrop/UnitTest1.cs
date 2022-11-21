using DragAnDrop.Driver;
using DragAnDrop.Page;

namespace DragAnDrop
{
    public class Tests
    {
        DragAndDropPage dragAndDrop;

        [SetUp]
        public void Setup()
        {
            WebDriver.Initialization();
            dragAndDrop = new DragAndDropPage();
        }
        [TearDown]
        public void Close()
        {
            WebDriver.CleanUp();
        }

        [Test]
        public void Test1()
        {
            dragAndDrop.MoveObject();
        }
        
      
        
    }
}