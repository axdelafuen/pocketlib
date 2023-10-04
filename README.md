# PocketLib

### To-Do

- [ ] Completer le navigatorVM

- [ ] Faire fonctionner la CI

- [ ] ContentView dans les pages

- [ ] Refaire la page de pret `LoanPage.xaml`, en reprennant le code forké de l'énoncé

- [ ] Faire en sorte que le menu contextuel soit accessible depuis toutes les pages

- [ ] Ajouter la vue de scan

- [x] Changer mon "header view" en -> ShellNavBar (cf fork de l'énoncé)

- [x] `NavigatorVM.cs` -> singleton

- [x] Changer le mode de navigation de `Shell.Current.GoToAsync()` en -> `(App.Current as App).MainPage.PushAsync(new Page())` = (pour fluidifier la navigation)

- [x] Supprimer le `private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)` dans le code-behind des views, les commands se font juste dans les VM.

- [x] Supprimer toute les VM de route -> remplacer par un `NavigatorVM.cs` et ajouter des parameters dans les `ButtonView` pour choisir les pages usr la quelle on veut aller

- [x] Passer de Book en BookVM -> utiliser un mapper (linq avec select)

- [x] Ajouter la bibliothèque de class et le stub