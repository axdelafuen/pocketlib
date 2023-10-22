# PocketLib

### To-Do

- [ ] Gérer les enum pour avoir des strings propre et modifiable (pas la merde qu'il ya dans le constructeur de BookVM actuellement)

- [ ] mon mvvm tool kit ?

- [ ] Faire fonctionner sonar

- [ ] Refaire la page de pret `LoanPage.xaml`, en reprennant le code forké de l'énoncé

- [ ] Ajouter la vue de scan

- [x] Faire en sorte que le menu contextuel soit accessible depuis toutes les pages


- [x] Faire les views de DetailsPage en BindableProperty + le bindings de la DetailsPage

- [x] Faire le SelectionChanged de la CollectionView

- [x] Completer le navigatorVM

- [x] ContentView dans les pages

- [x] Changer mon "header view" en -> ShellNavBar (cf fork de l'énoncé)

- [x] `NavigatorVM.cs` -> singleton

- [x] Changer le mode de navigation de `Shell.Current.GoToAsync()` en -> `(App.Current as App).MainPage.PushAsync(new Page())` = (pour fluidifier la navigation)

- [x] Supprimer le `private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)` dans le code-behind des views, les commands se font juste dans les VM.

- [x] Supprimer toute les VM de route -> remplacer par un `NavigatorVM.cs` et ajouter des parameters dans les `ButtonView` pour choisir les pages usr la quelle on veut aller

- [x] Passer de Book en BookVM -> utiliser un mapper (linq avec select)

- [x] Ajouter la bibliothèque de class et le stub