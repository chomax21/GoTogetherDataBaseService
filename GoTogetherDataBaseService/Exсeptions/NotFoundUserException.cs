namespace GoTogetherDataBaseService.Exсeptions
{
    public class NotFoundUserException : Exception
    {
        public int UserId { get; set; }
        public NotFoundUserException(string message, int Id) : base(message) 
        {
            UserId = Id;
        }
        // Записать лог
    }
}
