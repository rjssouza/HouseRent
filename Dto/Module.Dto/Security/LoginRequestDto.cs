namespace Module.Dto.Security
{
    /// <summary>
    /// Requisição de login
    /// </summary>
    public class LoginRequestDto
    {
        /// <summary>
        /// Email do usuário
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Senha do usuário
        /// </summary>
        public string Password { get; set; }
    }
}