Imports System
Imports Xunit

Namespace VisualBasicWinFormsCoreApp.Tests
    Public Class UnitTestMust
        <Fact>
        Sub Pass()
            Assert.Equal(7, 7)
        End Sub

        <Fact>
        Sub Fail()
            Assert.Equal(6, 7)
        End Sub
    End Class
End Namespace

