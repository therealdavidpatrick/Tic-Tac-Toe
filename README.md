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
