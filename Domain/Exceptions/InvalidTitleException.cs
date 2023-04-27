namespace Domain.Exceptions; 
internal sealed class InvalidTitleException : CustomException 
{ 
    public InvalidTitleException() : base("Title is not valid") 
    { 

    } 
}
