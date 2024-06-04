## Hiihtopeli C#:llä

Tämä on yksinkertainen hiihtopeli, joka on toteutettu C#-ohjelmointikielellä Windows Forms -sovelluksena.

### Kuvaus
Pelin tarkoituksena on ohjata hiihtäjää, välttää esteitä ja kerätä rahaa matkan varrella. Törmääminen esteisiin päättää pelin, mutta pelaaja voi aloittaa uuden pelin painamalla play again nappia.

### Pelin kulku
Pelaaja voi ohjata hiihtäjää nuolinäppäimillä tai A- ja D-näppäimillä. Kun hiihtäjä siirtyy vasemmalle, hänen sijaintinsa muuttuu enemmän vasemmalle. Kun hiihtäjä siirtyy oikealle, hänen sijaintinsa muuttuu enemmän oikealle.. Pelaaja voi kerätä kolikoita hiihtämällä niiden yli.

### Pelin ominaisuudet
- **Esteiden välttäminen**: Hiihtäjän on vältettävä kiviä ja puita.
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
5. Peli päättyy, kun hiihtäjä törmää esteeseen. Voit aloittaa uuden pelin painamalla "Pelaa uudelleen" -painiketta.


