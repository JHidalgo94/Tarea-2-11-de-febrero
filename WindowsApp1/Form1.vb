Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles promedioButton1.Click
        {
        
            Decimal n1 = Convert.ToDecimal(primerparcialTextBox1.Text)
            Decimal n2 = Convert.ToDecimal(segundoparcialTextBox2.Text)
            Decimal n3 = Convert.ToDecimal(tercerparcialTextBox3.Text)
            Decimal n4 = Convert.ToDecimal(cuartoparcialTextBox4.Text)

            Decimal promedio = Await promedioAsync(n1, n2, n3, n4);
            MessageBox.Show($"El promedio es {promedio}");
        }


        Private Async Task<Decimal> promedioAsync(Decimal p1, Decimal p2, Decimal p3, Decimal p3)
        {
            
         Decimal promedio = Await Task.run(() >=
            {
                 return p1 + p2 + p3 + p4) / 4;

            })
             Return promedioButton1;
        }


    End Sub
End Class
