# Virtual World 

# Presentazione

### E' un ecommerce creato appositamente per la vendita di videogiochi, tra cui i migliori in tendenza.
### Invece che andare di persona ad aquistare i prodotti che vorresti giocare lo puoi fare qui e ti arrivano direttamente a casa tua!
### Qui basta che fai il login e il gioco è fatto.
### Puoi tranquillamente scorrere tra i giochi ed aggiungere al carrello i tuoi preferiti dove vuoi e quando vuoi.
### Quindi......Cosa aspetti......entra con noi a far parte di Virtual World!

# Realizzazione
### Per realizzare questo progetto abbiamo prima di tutto creato una nuova cartella, e al suo interno abbiamo avviato il terminale.
### Nel terminale bisogna digitare un paio di comandi per la creazione e l'avvio del progetto ovvero :
```
dotnet new mvc
```
```
code .
```

### Dopo di che digitare nel terminale i seguinti comandi :
```
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
```
### Questi comandi servono per aggiungere i package. 
### Dopo questi comandi dobbiamo disinstallare e rinistallare i tool per avere l'ultima versione : 
```
dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-ef
```
### Dopo aver fatto ciò per controllare che sia andato tutto a buon fine digitare :
```
dotnet aspnet-codegenerator
dotnet ef
```
### E se spunta un unicorno con scritto al suo fianco EF dignifica che è andato tutto a buon fine.
### Poi andiamo a creare un nuovo foglio in c# e dentro di esso andiamo a collocarci questa classe
```
public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    public decimal Price { get; set; }
}
```

### Poi andiamo a digitare il seguente comando che andra a generale il database e le pagine inretenti.
```
dotnet aspnet-codegenerator controller -name MovieController -m Movie -dc dbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite
```
```
dotnet ef migrations add "prima versione"
dotnet ef database update
dotnet run
```


## Sviluppatori :  Paolo Francesco Pompa e Matteo Salvi
