Imports Serilog
Module SubscriptionEnd
    Sub Main()
        Dim log As ILogger = SubscriptionInfo.Info.getLogger


        If IO.File.Exists(SubscriptionInfo.Info.SubscriptionFile) Then
            IO.File.Delete(SubscriptionInfo.Info.SubscriptionFile)
        End If

        log.Information($"Ended subscription at {Now:G}.")


    End Sub

End Module
