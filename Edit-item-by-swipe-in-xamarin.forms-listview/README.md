# Edit listview item by swipe

The SfListView allows editing the item data using either [SfListView.RightSwipeTemplate](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~RightSwipeTemplate.html) or [SfListView.LeftSwipeTemplate] by loading edit view into the respective template after swiping the item.

```
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms">
 <syncfusion:SfListView > 
  <syncfusion:SfListView.RightSwipeTemplate> 
      <DataTemplate x:Name="RightSwipeTemplate"> 
        <Grid BackgroundColor="#DC595F" HorizontalOptions="Fill" VerticalOptions="Fill"> 
          <Grid> 
            <Label Grid.Row="0" 
                    HeightRequest="50" 
                    WidthRequest="50" 
                    BackgroundColor="Transparent" 
                    Text="EditItem"> 
               <Grid.GestureRecognizers>
                   <TapGestureRecognizer Tapped="TapGestureRecognizer_Tapped"/>
               </Grid.GestureRecognizers>
            </Label> 
          </Grid> 
        </Grid> 
      </DataTemplate> 
  </syncfusion:SfListView.RightSwipeTemplate> 
 </syncfusion:SfListView>
</ContentPage>
```
To set tapped items binding context for pop-up page, follow the code example.

```
private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
{
   var popupPage = new SfPopUpView();
   popupPage.BindingContext = (sender as Grid).BindingContext;
   Navigation.PushAsync(popupPage);
}
```

To know more about swiping in ListView , please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/swiping).