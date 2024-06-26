## Laskettelupeli C#:llä

Tämä on yksinkertainen laskettelupeli, joka on toteutettu C#-ohjelmointikielellä Windows Forms -sovelluksena.

### Kuvaus
Pelin tarkoituksena on ohjata laskettelijaa, välttää esteitä ja kerätä rahaa matkan varrella. Törmääminen esteisiin päättää pelin, mutta pelaaja voi aloittaa uuden pelin painamalla play again nappia.

### Pelin kulku
Pelaaja voi ohjata laskettelijaa nuolinäppäimillä tai A- ja D-näppäimillä. Kun hiihtäjä siirtyy vasemmalle, hänen sijaintinsa muuttuu enemmän vasemmalle. Kun hiihtäjä siirtyy oikealle, hänen sijaintinsa muuttuu enemmän oikealle.. Pelaaja voi kerätä kolikoita hiihtämällä niiden yli.

### Pelin ominaisuudet
- **Esteiden välttäminen**: Laskettelijan on vältettävä kiviä ja puita.
- **Kolikoiden kerääminen**: Pelaaja voi kerätä kentälle satunnaisesti ilmestyviä kolikoita ja seteleitä.
- **Pisteiden kerääminen**: Pelaaja ansaitsee pisteitä etenemisestään. Pisteet lasketaan pelaajan hiihtämän matkan perusteella.
- **Äänitehosteet**: Pelissä on äänitehosteita, kuten kolikon keräämisen ääni.

### Pelin kehitys
Tämä peli on kehitetty C#-ohjelmointikielellä käyttäen Windows Forms -sovelluskehystä. Pelin logiikka ja käyttöliittymä on toteutettu Box-luokassa, ja se käyttää Timer-komponenttia pelimaailman jatkuvaan päivittämiseen.

### Ohjeet
1. Kloonaa tai lataa tämä projekti paikalliselle koneellesi.
2. Avaa projekti Visual Studio -kehitysympäristössä tai vastaavassa C#-kehitystyökalussa.
3. Rakenna ja suorita projekti.
4. Ohjaa hiihtäjää välttääksesi esteitä ja kerätäksesi kolikoita.
5. Peli päättyy, kun hiihtäjä törmää esteeseen, mutta voit aloittaa uuden pelin painamalla "Pelaa uudelleen" -painiketta.

### Kuvia pelistä
Pelinäkymä kun peli on käynnissä, vasemmassa yläkulmassa pisteet ja kerätyt rahat näkyvät sekä päivittyvät realiajassa.

![image](https://github.com/lenaboi/csharp_project/assets/163280952/30cbe551-93e0-440e-8ef0-3c4941849ea0)

Pelinäkymä kun peli on loppunut. Play again napilla pääsee aloittamaan pelin uudestaan heti.

![image](https://github.com/lenaboi/csharp_project/assets/163280952/02894960-23b5-4391-b513-5fd526151776)

### Jatkokehitys
1. Peliin voisi yrittää tehdä esimerkiksi jonkintyylisen kaksinpelin.
2. Peliin voisi tehdä leaderboard systeemin, jossa näkyy top 5 parhaat scoret.
3. Ennen kuin peli alkaa pelaajalta kysyttäisiin haluaako pelata helppo, keskivaikea vai vaikea ja pelin vaikeustaso määrittyisi sen mukaan.
   

### Vuokaavio
![image](https://github.com/lenaboi/csharp_project/assets/163280952/743789bf-4b66-42f1-bfa5-94b029595ae3)


