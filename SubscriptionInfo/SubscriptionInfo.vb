Imports System.Reflection
Imports Serilog

Public Class Info
    Shared ReadOnly Property SubscriptionFile
        Get

            Return IO.Path.Combine(ExeFolder, "subscriptionDetails.dat")
        End Get
    End Property
    Shared ReadOnly Property ExeFolder As String = IO.Path.GetDirectoryName(Assembly.GetEntryAssembly.Location)

    Shared Function getLogger() As ILogger
        Dim cfg As New LoggerConfiguration
        cfg.WriteTo.File(IO.Path.Combine(ExeFolder, "Subscriptions.log"))

        Return cfg.CreateLogger()
    End Function
End Class
