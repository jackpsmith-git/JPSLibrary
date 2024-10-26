namespace Jpsmith.Application;

/// <summary>
/// Result pattern implementation
/// </summary>
/// <typeparam name="T">The type of argument "data"</typeparam>
/// <param name="result">Result of the encapsulating function</param>
/// <param name="data">Return data of the encapsulating function</param>
public class ResultWithData<T>(int result, T data)
{
    /// <summary>
    /// Returns 0 if the code ran successfully, otherwise returns 1
    /// </summary>
    public int Result { get; set; } = result;

    /// <summary>
    /// Return data of the encapsulating function
    /// </summary>
    public T Data { get; set; } = data;
}