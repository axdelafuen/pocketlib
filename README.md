# PocketLib

### To-Do

[ ] Changer mon "header view" en -> ShellNavBar (cf fork de l'énoncé)

[ ] Changer le mode de navigation de `Shell.Current.GoToAsync()` en -> `(App.Current as App).MainPage.PushAsync(new Page())` = (pour fluidifier la navigation)

[ ] Refaire la page de pret `LoanPage.xaml`, en reprennant le code forké de l'énoncé

[ ] Faire en sorte que le menu contextuel soit accessible depuis toutes les pages

[ ] Ajouter la vue de scan

[ ] Supprimer le `private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)` dans le code-behind des views, les commands se font juste dans les VM.

[ ] Supprimer toute les VM de route -> remplacer par un `NavigatorVM.cs` et ajouter des parameters dans les `ButtonView` pour choisir les pages usr la quelle on veut aller