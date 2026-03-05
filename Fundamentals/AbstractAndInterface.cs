public interface Ireportable
{
    string GenerateReport();
}

public interface Inotifiable
{
    void Notify(string channel);
}

public abstract class NetworkThreat : Ireportable, Inotifiable
{
    public string SourceIP { get; private set; }
    public DateTime DetectedAt { get; private set; }
    public bool IsContained { get; protected set; }

    protected NetworkThreat(string sourceIP)
    {
        SourceIP = sourceIP;
        DetectedAt = DateTime.UtcNow;
        IsContained = false;
    }

    public abstract string ThreatName { get; }
    public abstract void Execute();
    public abstract void Contain();

    // Concrete — shared across all threats

    public virtual void Escalate()
    {
        Console.WriteLine($"[{ThreatName}] Escalating from {SourceIP}");
    }

    // Interface contracts - concrete implementations in abstract class
    public string GenerateReport()
    {
        return $"Threat: {ThreatName} | Source: {SourceIP} | Detected: {DetectedAt} | Contained: {IsContained}";
    }

    // Interface contract - abstract, each subclass notifies differently
    public abstract void Notify(string channel);
}

// Concrete class 1
public class DDoSAttack : NetworkThreat
{
    public int PacketsPerSecond { get; private set; }

    public DDoSAttack(string sourceIP, int pps) : base(sourceIP)
    {
        PacketsPerSecond = pps;
    }

    public override string ThreatName => "DDoS Attack";

    public override void Execute()
    {
        Console.WriteLine($"Flooding {SourceIP} at {PacketsPerSecond} pkt/s");
    }

    public override void Contain()
    {
        IsContained = true;
        Console.WriteLine($"Rate-limiting and null-routing {SourceIP}");
    }

    public override void Notify(string channel)
    {
        Console.WriteLine($"[DDoS] Sending alert to {channel}: {PacketsPerSecond} pkt/s from {SourceIP}");
    }
}

// Concrete class 2
public class PhishingAttack : NetworkThreat
{
    public string FakeURL { get; private set; }

    public PhishingAttack(string sourceIP, string fakeURL) : base(sourceIP)
    {
        FakeURL = fakeURL;
    }

    public override string ThreatName => "Phishing Attack";

    public override void Execute()
    {
        Console.WriteLine($"Serving fake login page at {FakeURL} from {SourceIP}");
    }

    public override void Contain()
    {
        IsContained = true;
        Console.WriteLine($"Blacklisting {FakeURL} and blocking {SourceIP}");
    }

    public override void Notify(string channel)
    {
        Console.WriteLine($"[Phishing] Alerting {channel}: malicious URL {FakeURL}");
    }

    // Overriding escalate with more specific behavior
    public override void Escalate()
    {
        base.Escalate();
        Console.WriteLine($"  Also notifying email security team about {FakeURL}");
    }

}

static class AbstractAndInterface
{
    public static void Run()
    {
        // Polymorphic array — base type holds derived objects
        NetworkThreat[] threats =
        [
            new DDoSAttack("203.0.113.42", 1_500_000),
            new PhishingAttack("198.51.100.7", "https://secure-bank-login.fake.com")
        ];

        foreach (NetworkThreat threat in threats)
        {
            threat.Execute();
            threat.Escalate();
            threat.Notify("Slack-#incidents");
            threat.Contain();
            Console.WriteLine(threat.GenerateReport());
            Console.WriteLine();
        }

        // Explicit interface reference
        Ireportable reporter = new DDoSAttack("1.2.3.4", 999);
        Console.WriteLine(reporter.GenerateReport());
    }
}