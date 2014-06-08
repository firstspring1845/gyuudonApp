/*
 * Created by SharpDevelop.
 * User: owner
 * Date: 2014/06/08
 * Time: 16:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace gyuudonApp
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}
		
		void textBox1_TextChanged(object sender, TextChangedEventArgs e)
		{
			try{
				kg = (sender as TextBox).Text;
				g = String.Format("{0:f3}", int.Parse(kg) / 100.0);
				DataContext = new{gyuudon = g};
			}catch(Exception ex){
				DataContext = new{gyuudon = "Error"};
			}
		}
		
		public string g {get; set;}
		
		public string kg {get; set;}
		
		void tweetClick(object sender, RoutedEventArgs e)
		{
			System.Diagnostics.Process.Start(String.Format("https://twitter.com/intent/tweet?text={0}kgは {1}ぎゅうどん です！&hashtags=ぎゅうどん式健康計算機", kg, g));
		}
		
		void exitClick(object sender, RoutedEventArgs e)
		{
			Environment.Exit(0);
		}
	}
}