(function () {
    'use strict';

    angular
        .module('angularDemoApp')
        .controller('homeController', homeController);

    homeController.$inject = ['dataFactory'];

    function homeController(dataFactory) {
        /* jshint validthis:true */
        var vm = this;
        vm.getFolderInfo = getFolderInfo;
        vm.title = 'homeController';
        
        activate();

        function activate() {
            getFolderInfo("d", "Denys_doc/books");
        }

       
        function getFolderInfo(disk, path) {
            dataFactory.getAllData(disk,path)
                .success(function (result) {
                    vm.data = result;
                    console.log (result);
                })
                .catch(function (exception) {
                    var ex = exception;
                });
        };

    }
})();
