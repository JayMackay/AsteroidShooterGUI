using NUnit.Framework;
using AsteroidShooterGUI;
using AsteroidShooterGUI.Test_Cases;

namespace RegistrationUnitTests
{
    public class RegistrationTests
    {
        private TestMethods registration;

        [SetUp]
        public void Setup()
        {
            registration = new TestMethods();
        }

        //VALID REGISTRATION TEST
        [Test]
        public void ValidRegistration()
        {
            registration.Username = "JayMackay94";
            registration.Password = "Password";
            var message = registration.Registration();
            Assert.AreEqual("You have registered successfully!", message);
        }

        //INVALID REGISTRATION TEST
        [Test]
        public void InvadlidRegistration()
        {
            registration.Username = "JayMackay94";
            registration.Password = null;
            var message = registration.Registration();
            Assert.AreEqual("Please input in your name or password", message);
        }

        //PASSWORD CONFIRMATION
        [Test]
        public void PasswordConfirmation()
        {
            registration.Password = "Password";
            registration.PasswordConfirmation = "Password";
            var message = registration.Confirmation();
            Assert.AreEqual("You have registered successfully!", message);
        }

        //INVALID CONFIRMATION
        [Test]
        public void InvalidPasswordConfirmation()
        {
            registration.Password = "Password";
            registration.PasswordConfirmation = "Passwor";
            var message = registration.Confirmation();
            Assert.AreEqual("Password is not matching", message);
        }
    }
}