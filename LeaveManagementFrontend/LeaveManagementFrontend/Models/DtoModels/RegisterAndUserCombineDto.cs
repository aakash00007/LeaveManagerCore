namespace LeaveManagementFrontend.Models.DtoModels
{
    public class RegisterAndUserCombineDto
    {
        public UserRegisterationDto? UserRegisterationDto { get; set; }
        public IEnumerable<UserDto>? UserDto { get; set; }
    }
}
