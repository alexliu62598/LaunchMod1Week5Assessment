using LaunchMod1Week5Assessment;

namespace UserTests
{
    public class UserTest
    {
        [Fact]
        public void User_WhenInstantiated_IsCreatedWithDesiredProperties()
        {
            var user = new User("alex", "alex@gmail.com");
            Assert.Equal("alex", user.Name);
            Assert.Equal("alex@gmail.com", user.Email);
            Assert.False(user.IsLoggedIn);
        }

        [Fact]
        public void IsSetupComplete_ReturnsCorrectBoolValue()
        {
            var user = new User("alex", "alex@gmail.com");
            user.CreatePassword("alex@gmail.com", "dog123");
            Assert.True(user.IsSetupComplete());

            var user2 = new User("kevin", "kevin@hotmail.com");
            Assert.False(user2.IsSetupComplete());
        }

        [Fact]
        public void CreatePassword_SetsValueOfPasswordPropertyAndReturnsConfirmation()
        {
            var user = new User("alex", "alex@gmail.com");
            user.CreatePassword("alex@gmail.com", "dog123");
            Assert.Equal("Password Created", user.CreatePassword("alex@gmail.com", "dog123"));
        }

        [Fact]
        public void LogIn_ReturnsDesiredString() 
        {
            var user = new User("alex", "alex@gmail.com");
            user.CreatePassword("alex@gmail.com", "dog123");
            Assert.Equal("Logged In", user.LogIn("dog123"));
        }

        [Fact]
        public void LogOut_ReturnsDesiredBoolValue()
        {
            var user = new User("alex", "alex@gmail.com");
            Assert.False(user.IsLoggedIn);

            user.CreatePassword("alex@gmail.com", "dog123");
            user.LogIn("dog123");
            Assert.True(user.IsLoggedIn);

            user.LogOut();
            Assert.False(user.IsLoggedIn);
        }
    }
}