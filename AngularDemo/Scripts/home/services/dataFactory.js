(function () {
    'use strict';

    angular
        .module('angularDemoApp')
        .factory('dataFactory', dataFactory);

    dataFactory.$inject = ['$http'];

    function dataFactory($http) {
        var service = {
            getAllData: getAllData
        };

        return service;

        
        function getAllData(disk,path) {
            return $http.get("http://localhost:49457/api/DirectoryDetails/" + disk + "/" + path);
        }
    }
})();