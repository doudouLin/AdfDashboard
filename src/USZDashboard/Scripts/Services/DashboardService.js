(function () {
    'use strict';

    var DashboardService = angular.module('DashboardService', ['ngResource']);
    DashboardService.factory('DashboardsFactory', ['$resource',
        function ($resource) {

            //var resource = $resource('/DashboardAdmin/USZDashboard', {}, {
            //        query: { method: 'GET', params: {}, isArray: true }
            //});

            //return {
            //    GetAllDashboards: function () {
            //        resource.query().$promise.then(function (data) {
            //            console.log('hihi this is data');
            //            console.log(data);
            //            return data;
            //        });
            //    }
            //}


            return $resource('/DashboardAdmin/USZDashboard/:dashboardId', {dashboardId:'@id'}, {
                query: { method: 'GET', params: {}, isArray: false }
            });
        }
    ]);
})();