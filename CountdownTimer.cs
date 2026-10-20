public class CountdownTimer
{
    public event EventHandler<int>? Tick;
    public event EventHandler? Finished;

    public void Start(int seconds)
    {
        while (seconds > 0)
        {
            Thread.Sleep(1000);
            seconds--;
            Tick?.Invoke(this, seconds);
        }

        Finished?.Invoke(this, EventArgs.Empty);
    }
}
