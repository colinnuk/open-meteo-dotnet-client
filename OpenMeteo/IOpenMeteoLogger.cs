namespace OpenMeteo
{
    /// <summary>
    /// Specifies a simple interface for a logger.
    /// Usage of this interface is optional.
    /// To use this, create your own implementation of this interface which you can easily setup
    ///  to call your own logging framework.
    /// </summary>
    public interface IOpenMeteoLogger
    {
        void Information(string message);
        void Warning(string message);
        void Error(string message);
        void Debug(string message);
    }
}