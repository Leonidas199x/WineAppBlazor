function getMap(latitude, longitude, region) {
    var map = new Microsoft.Maps.Map('#myMap', {
        center: new Microsoft.Maps.Location(latitude, longitude)
    });

    var center = map.getCenter();

    var pin = new Microsoft.Maps.Pushpin(center, {
        title: region,
        color: 'maroon',
        text: 'x'
    });

    map.entities.push(pin);
}