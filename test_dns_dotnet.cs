using System;
using System.Net;

class DnsTest {
    static void Main() {
        string[] domains = {
            "web-frontend-server",
            "app-backend.cloud.local",
            "minio.cloud.local",
            "keycloak.cloud.local"
        };

        string[] expectedIPs = {
            "10.10.10.10",
            "10.10.10.20",
            "10.10.10.30",
            "10.10.10.40"
        };

        Console.WriteLine("Testing DNS Resolution (Port 1053)...");
        Console.WriteLine("=====================================");

        for (int i = 0; i < domains.Length; i++) {
            try {
                Console.Write($"Testing {domains[i]}... ");

                // Use custom DNS server (this won't work in .NET easily)
                // For now, just try to resolve normally
                IPHostEntry hostEntry = Dns.GetHostEntry(domains[i]);
                string resolvedIP = hostEntry.AddressList[0].ToString();

                if (resolvedIP == expectedIPs[i]) {
                    Console.WriteLine($"SUCCESS: {resolvedIP}");
                } else {
                    Console.WriteLine($"MISMATCH: Expected {expectedIPs[i]}, got {resolvedIP}");
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"FAILED: {ex.Message}");
            }
        }
    }
}
