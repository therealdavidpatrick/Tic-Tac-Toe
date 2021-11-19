# Tic-Tac-Toe

Two player game. One player chooses "X" and the other player chooses "O."
Three-by-three grid. 
Each player places an "X" or an "O" on any one cell of the grid. 
The first player to mark three "Xs" or "Os" vertically, horizontally, or diagonally in a row wins the game. 
When game ends, click any part of the grid to generate message, "Game Over, Players!"


PROJECT FEATURES

1. Use a LINQ query to retrieve information from a data structure (such as a list or array) or file 

MainWindow.xaml.cs
Lines 51-58 
private void NewGame()
        {
            mResults = new MarkType[9];

            for (var i = 0; i < mResults.Length; i++)
                mResults[i] = MarkType.Free; 
         }


2. Visualize data in a graph, chart, or other visual representation of data

MainWindow.xaml
Lines 1 - 45
<Window x:Class="Tic_Tac_Toe.MainWindow" 
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Tic_Tac_Toe"
        mc:Ignorable="d"
        ResizeMode="NoResize"
        Title="Tic Tac Toe" Height="500" Width="500">

    <Window.Resources>
        <Style TargetType="Button">
            <Setter Property="Background" Value="White" />
            <Setter Property="BorderThickness" Value="4" />
            <Setter Property="FontSize" Value="90" />            
        </Style>
    </Window.Resources>
    
    <Grid x:Name="TicTacToeGrid">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*" />
            <ColumnDefinition Width="*" />
            <ColumnDefinition Width="*" />
        </Grid.ColumnDefinitions>
        
        <Grid.RowDefinitions>
            <RowDefinition Height="*" />
            <RowDefinition Height="*" />
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>

        <Button Click="Button_Click" x:Name="Button0_0" Grid.Column="0" Grid.Row="0" Content="X"/>
        <Button Click="Button_Click" x:Name="Button1_0" Grid.Column="1" Grid.Row="0" Content="O"/>
        <Button Click="Button_Click" x:Name="Button2_0" Grid.Column="2" Grid.Row="0" />
                
        <Button Click="Button_Click" x:Name="Button0_1" Grid.Column="0" Grid.Row="1" />
        <Button Click="Button_Click" x:Name="Button1_1" Grid.Column="1" Grid.Row="1" />
        <Button Click="Button_Click" x:Name="Button2_1" Grid.Column="2" Grid.Row="1" />

        <Button Click="Button_Click" x:Name="Button0_2" Grid.Column="0" Grid.Row="2" />
        <Button Click="Button_Click" x:Name="Button1_2" Grid.Column="1" Grid.Row="2" />
        <Button Click="Button_Click" x:Name="Button2_2" Grid.Column="2" Grid.Row="2" />

    </Grid>
</Window>



3. Create an additional class which inherits one or more properties from its parent

MainWindow.xaml.cs
Line 12 
public partial class MainWindow : Window 



4. Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program

MainWindow.xaml.cs
Lines 81-135 
private void Button_Click(object sender, RoutedEventArgs e) // Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program
        {
            // Once game ends, a single click triggers a new restarted game 
            if (mGameEnded)
            {

                WinnerOutput wO = new WinnerOutput(); // Create a METHOD ( i.e. a function within a class )
                wO.Message = "Game Over, Players!";
                MessageBoxResult result = MessageBox.Show(wO.Message); // Return a VALUE that is used in the application ( i.e. not void )
                NewGame();
                return;
            }

            // Cast the sender to a button
            var button = (Button)sender;

            // Find the buttons position in the array
            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);

            var index = column + (row * 3);

            // Don't do anything if the cell already has a value in it
            if (mResults[index] != MarkType.Free)
                return;

            // Set the cell value based on which player's turn it is 
            if (mPlayer1Turn)
                mResults[index] = MarkType.Ex;
            else
                mResults[index] = MarkType.Zero;

            // Set button text to the result
            if (mPlayer1Turn)
                button.Content = "X";
            else
                button.Content = "O";

            // Change the "Xs" to yellow
            if (mPlayer1Turn)
                button.Foreground = Brushes.Yellow;

            // Toggle the players' turns 
            if (mPlayer1Turn)
                mPlayer1Turn = false;
            else
                mPlayer1Turn = true;

            // Check for a winner
            CheckForWinner();
        }

        /// <summary>
        /// Checks if there is a winner of a 3 line straight
        /// </summary>


