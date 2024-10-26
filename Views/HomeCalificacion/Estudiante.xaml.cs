namespace jescobarS3.Views.HomeCalificacion;

public partial class Estudiante : ContentPage
{
    public Estudiante()
    {
        InitializeComponent();
    }
    private void OnCalculateClicked(object sender, EventArgs e)
    {
        try
        {
            // Obteniendo valores de notas y exámenes
            double seg1 = Convert.ToDouble(notaSeg1.Text);
            double exam1 = Convert.ToDouble(examen1.Text);
            double seg2 = Convert.ToDouble(notaSeg2.Text);
            double exam2 = Convert.ToDouble(examen2.Text);

            // Cálculo de notas parciales y final
            double parcial1 = (seg1 * 0.3) + (exam1 * 0.2);
            double parcial2 = (seg2 * 0.3) + (exam2 * 0.2);
            double notaFinal = parcial1 + parcial2;

            // Determinación del estado
            string estado;
            if (notaFinal >= 7) estado = "Aprobado";
            else if (notaFinal >= 5) estado = "Complementario";
            else estado = "Reprobado";

            // Mostrar resultados en DisplayAlert
            DisplayAlert("Resultados",
                $"Nombre: {pickerEstudiante.SelectedItem}\n\nFecha: {datePickerFecha.Date.ToShortDateString()}\n\n" +
                $"Nota Parcial 1: {parcial1:F2}\n\nNota Parcial 2: {parcial2:F2}\n\n" +
                $"Nota Final: {notaFinal:F2}\n\nEstado: {estado}", "OK");
        }
        catch (Exception)
        {
            DisplayAlert("Error", "Verifique los datos ingresados. Asegúrese de que todas las notas sean numéricas.", "OK");
        }
    }

}