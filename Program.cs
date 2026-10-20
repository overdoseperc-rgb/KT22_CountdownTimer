int initialSeconds = 6;
var timer = new CountdownTimer();

void ShowTime(object? sender, int seconds)
{
    Console.WriteLine($"Осталось секунд: {seconds}");
}

void SecondHandler(object? sender, int seconds)
{
    Console.WriteLine($"Второй обработчик: {seconds}");

    if (seconds < initialSeconds / 2.0)
    {
        timer.Tick -= SecondHandler;
        Console.WriteLine("Второй обработчик отписался");
    }
}

void ShowFinished(object? sender, EventArgs e)
{
    Console.WriteLine("Таймер завершён!");
}

timer.Tick += ShowTime;
timer.Tick += SecondHandler;
timer.Finished += ShowFinished;

timer.Start(initialSeconds);
