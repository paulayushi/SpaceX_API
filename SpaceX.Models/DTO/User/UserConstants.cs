namespace SpaceX.Models.DTO.User
{
    public class UserConstants
    {
        public static List<UserModel> Users = new()
        {
                new UserModel(){ Username="superuser",Password="Password@2023",Role="Admin"}
        };
    }
}
