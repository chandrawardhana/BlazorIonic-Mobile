namespace BlazorIonic.Data
{
    public interface ILiveSharpRuntime
    {
        object Config { get; }

        void UseDefaultBlazorHandler();
    }
}