function getMap(latitude, longitude, region) {
    var map = new Microsoft.Maps.Map('#myMap', {
        center: new Microsoft.Maps.Location(latitude, longitude)
    });

    var center = map.getCenter();

    //Create custom Pushpin
    var pin = new Microsoft.Maps.Pushpin(center, {
        title: region,
        color: 'maroon',
        text: 'x'
    });

    //Add the pushpin to the map
    map.entities.push(pin);
}