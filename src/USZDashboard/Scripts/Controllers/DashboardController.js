(function () {
    'use strict';

    angular
        .module('DashboardAdmin')
        .controller('DashboardController', ['$scope', 'DashboardsFactory', function ($scope, DashboardsFactory) {
            $scope.dashboard = DashboardsFactory.query({ dashboardId: 2 });
            console.log($scope.dashboard);
            //$scope.dashboard.$promise.then(function (data) {
            //    console.log(data);
            //});
        }]);
})();
