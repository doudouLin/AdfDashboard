//(function () {
//    'use strict';

//    angular
//        .module('DashboardAdmin')
//        .controller('DashboardController', ['$scope', 'DashboardsFactory', function ($scope, DashboardsFactory) {
//            var nav = this;

//            DashboardsFactory.GetAllDashboards().then(function (data) {
//                nav.items = data;
//            });

//            $scope.$on('navChanged', function () {
//                DashboardsFactory.GetAllDashboards().then(function (data) {
//                    nav.items = data;
//                });
//            });
//            //$scope.dashboard = DashboardsFactory.GetDashboardById({ dashboardId: 2 });

//            //console.log($scope.dashboard);
//            //$scope.dashboard.$promise.then(function (data) {
//            //    console.log(data);
//            //});
//        }]);
//})();
