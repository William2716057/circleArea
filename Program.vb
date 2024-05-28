Imports System

Module CircleArea
	Sub Main()
		' user prompt
		Console.Write("Enter radius: ")
		Dim radius As Double = CDbl(Console.ReadLine())

		' Calculation
		Dim area As Double = Math.PI * radius * radius
		' Display result
		Console.WriteLine("Circle area: " & area)
	End Sub
End Module