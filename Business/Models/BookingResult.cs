namespace Business.Models;


public enum ResponseStatus
{
    Success,
    NotFound,
    Found,
    Invalid,
    Error
}

public class BookingResult
{
    public bool IsSuccess { get; set; }
    public ResponseStatus? Status { get; set; }
    public string? ErrorMessage { get; set; }


}
public class BookingResult<T> : BookingResult
{
    public T? Result { get; set; }
}
