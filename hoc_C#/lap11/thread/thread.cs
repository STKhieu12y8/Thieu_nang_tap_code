using System.Threading;
public class OtherThread {
    public static void RunThread() {
        Thread.Sleep(2000);
        Console.WriteLine("orther thread running...");
    }

    public static Thread GetInstanceThread() {
        return new Thread(RunThread);
    }
}