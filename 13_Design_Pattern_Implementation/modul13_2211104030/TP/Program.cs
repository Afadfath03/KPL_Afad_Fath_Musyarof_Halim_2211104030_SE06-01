using System;

public class NewsPublisher {
    public event EventHandler<string> NewsPublished;

    private string _latestNews;

    public void SetNews(string news) {
        _latestNews = news;
        OnNewsPublished();
    }

    protected virtual void OnNewsPublished() {
        NewsPublished?.Invoke(this, _latestNews);
    }
}

public class EmailSubscriber
{
    private string _email;

    public EmailSubscriber(string email) {
        _email = email;
    }

    public void HandleNewsUpdate(object sender, string news) {
        Console.WriteLine($"Email ke {_email}: {news}");
    }
}

public class Program {
    static void Main(string[] args) {
        var newsPublisher = new NewsPublisher();

        var userA = new EmailSubscriber("user_a@example.com");
        var userB = new EmailSubscriber("user_b@example.com");

        // Langganan event
        newsPublisher.NewsPublished += userA.HandleNewsUpdate;
        newsPublisher.NewsPublished += userB.HandleNewsUpdate;

        newsPublisher.SetNews("Harga BBM turun 10%!");

        // Berhenti berlangganan
        newsPublisher.NewsPublished -= userB.HandleNewsUpdate;
        newsPublisher.SetNews("Update: Harga BBM naik kembali.");

        Console.ReadLine();
    }
}