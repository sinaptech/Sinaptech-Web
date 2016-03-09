app.service("diseaseService", function ($http) {

    this.getInfo = function (id) {
        var req = $http.get('/api/Disease/' + id);
        return req;
    };

    this.getAppInfo = function () {
        var req = $http.get('/api/Disease');
        return req;
    }

    this.postInfo = function (diseaseInfo) {
        var req = $http.post('/api/Disease', diseaseInfo);
        return req;
    };

});