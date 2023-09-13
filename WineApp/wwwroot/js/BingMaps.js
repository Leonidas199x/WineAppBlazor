function getMap(latitude, longitude, location) {
    var map = new Microsoft.Maps.Map('#myMap', {
        center: new Microsoft.Maps.Location(latitude, longitude)
    });

    var center = map.getCenter();

    var pin = new Microsoft.Maps.Pushpin(center, {
        title: location,
        color: 'maroon',
        text: 'x'
    });

    map.entities.push(pin);
}