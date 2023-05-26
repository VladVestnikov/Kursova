using Kursova;
using Kursova.Class;
using Microsoft.PowerBI.Api;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.Configuration;

namespace TestKursova
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRegisterUser_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            string login = "abcdefghi";
            string password = "1234567890";

            RegistrUser user = new RegistrUser(login, password);

            // Act
            bool result = user.registerUser(login, password);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestRegisterUser_EmptyCredentials_ReturnsFalse()
        {
            // Arrange
            string login = "";
            string password = "";

            RegistrUser user = new RegistrUser(login, password);

            // Act
            bool result = user.registerUser(login, password);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestRegisterUser_InvalidLoginLength_ReturnsFalse()
        {
            // Arrange
            string login = "12345678";
            string password = "password";

            RegistrUser user = new RegistrUser(login, password);

            // Act
            bool result = user.registerUser(login, password);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestRegisterUser_InvalidPasswordLength_ReturnsFalse()
        {
            // Arrange
            string login = "username";
            string password = "pass";

            RegistrUser user = new RegistrUser(login, password);

            // Act
            bool result = user.registerUser(login, password);

            // Assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void RegisterTeacher_Should_AddTeacherToUsersList()
        {
            // Arrange
            string login = "teacher123";
            string password = "teacherpass";
            UserRepos repos = new UserRepos();

            // Act
            repos.RegisterTicher(login, password);

            // Assert
            Assert.AreEqual(1, UserRepos.Users.Count);
        }

        [TestMethod]
        public void RegisterStudent_Should_AddStudentToUsersList()
        {
            // Arrange
            string login = "student456";
            string password = "studentpass";
            UserRepos repos = new UserRepos();

            // Act
            repos.RegisterStudent(login, password);

            // Assert
            Assert.AreEqual(1, UserRepos.Users.Count);
        }

        [TestMethod]
        public void RemoveUser_Should_RemoveUserFromUsersList()
        {
            // Arrange
            string login = "user789";
            string password = "userpass";
            UserRepos repos = new UserRepos();
            repos.RegisterUser(login, password);

            // Act
            bool removed = UserRepos.RemoveUser(login);

            // Assert
            Assert.IsTrue(removed);
            Assert.AreEqual(0, UserRepos.Users.Count);
        }

        [TestMethod]
        public void RegisterUser_Should_ThrowException_WhenAccountAlreadyExists()
        {
            // Arrange
            string login = "existinguser";
            string password = "userpass";
            UserRepos repos = new UserRepos();
            repos.RegisterUser(login, password);

            // Act & Assert
            Assert.ThrowsException<Exception>(() => repos.RegisterUser(login, password));
        }

        [TestMethod]
        public void SaveUsers_Should_SaveUsersToFile()
        {
            // Arrange
            string path = "test_users.txt";
            UserRepos repos = new UserRepos();
            repos.RegisterUser("user1", "pass1");
            repos.RegisterUser("user2", "pass2");

            // Act
            UserRepos.SaveUsers(path);

            // Assert
            Assert.IsTrue(File.Exists(path));

            // Clean up
            File.Delete(path);
        }


    }
}