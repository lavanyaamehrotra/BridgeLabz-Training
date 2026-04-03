using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
public class EventTracker{
    List<object> auditLogs = new List<object>();
    // Scan methods with AuditTrail annotation
    public void ScanAuditedEvents(){
        auditLogs.Clear();
        Assembly assembly = Assembly.GetExecutingAssembly();
        var classes = assembly.GetTypes().Where(t => t.IsClass);
        foreach (var cls in classes){
            var methods = cls.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (var method in methods){
                var audit = method.GetCustomAttribute<AuditTrailAttribute>();
                if (audit != null){
                    var log = new{
                        Action = audit.ActionName,
                        Class = cls.Name,
                        Method = method.Name,
                        Time = DateTime.Now
                    };
                    auditLogs.Add(log);
                }
            }
        }
        Console.WriteLine("\nAudit scan completed.");
    }
    // Show JSON logs
    public void ShowJsonLogs(){
        if (auditLogs.Count == 0){
            Console.WriteLine(" No audit logs found. Run scan first.");
            return;
        }
        string json = JsonSerializer.Serialize(auditLogs,new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine("\nAudit Logs (JSON):\n");
        Console.WriteLine(json);
    }
}
