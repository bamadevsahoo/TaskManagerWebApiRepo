using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManagerAPI.Controllers;
using System.Web;
using System.Web.Http;

namespace TaskManagerAPI.Tests
{
    [TestClass]
    public class TaskManagerApiTest
    {
        [TestMethod]
        public void GetTasksTest()
        {    //Arrange
            TasksController tasksController = new TasksController();
            //Act
            IQueryable<Task> result = tasksController.GetTasks() as IQueryable<Task>;
            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetTaskTest()
        {    //Arrange
            TasksController tasksController = new TasksController();
            //Act
            IHttpActionResult result = tasksController.GetTask(1) as IHttpActionResult;
            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void PutTaskTest()
        {    //Arrange
            TasksController tasksController = new TasksController();
            Task task = new Task();
            task.TaskID = 1;
            task.Task1 = "Task1";
            task.StartDate = DateTime.Now.Date;
            task.EndDate = DateTime.Now.Date;
            task.Priority = 15;
            task.ParentId = 1;
            task.IsTaskEended = "1";
            //Act
            IHttpActionResult result = tasksController.PutTask(1, task) as IHttpActionResult;
            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PutEndTaskTest()
        {    //Arrange
            TasksController tasksController = new TasksController();
            Task task = new Task();
            task.TaskID = 1;
            task.Task1 = "Task1";
            task.StartDate = DateTime.Now.Date;
            task.EndDate = DateTime.Now.Date;
            task.Priority = 15;
            task.ParentId = 1;
            task.IsTaskEended = "1";
            //Act
            IHttpActionResult result = tasksController.PutEndTask( task) as IHttpActionResult;
            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void PostTaskTest()
        {    //Arrange
            TasksController tasksController = new TasksController();
            Task task = new Task();
            task.TaskID = 1;
            task.Task1 = "Task1";
            task.StartDate = DateTime.Now.Date;
            task.EndDate = DateTime.Now.Date;
            task.Priority = 15;
            task.ParentId = 1;
            task.IsTaskEended = "1";
            //Act
            IHttpActionResult result = tasksController.PostTask(task) as IHttpActionResult;
            //Assert
            Assert.IsNotNull(result);
        }
    }
}
