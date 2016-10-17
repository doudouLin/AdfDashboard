//(function () {
//    'use strict';

//    //angular.module('DashboardService', ['ngResource'])
//    //.service('DashboardsFactory', ['$http', '$q', function ($http, $q) {
//    //    return {
//    //        GetDashboardById: function (id) {
//    //            var deferred = $q.defer();
//    //            $http.get('/DashboardAdmin/USZDashboard/' + id)
//    //                .success(function (data) {
//    //                    deferred.resolve(data);
//    //                })
//    //                .error(function () {
//    //                    deferred.reject();
//    //                });
//    //            return deferred.promise;
//    //        },
//    //        GetAllDashboards: function () {
//    //            var deferred = $q.defer();
//    //            $http.get('/DashboardAdmin/USZDashboard')
//    //                .success(function (data) {
//    //                    deferred.resolve(data);
//    //                })
//    //                .error(function () {
//    //                    deferred.reject();
//    //                });
//    //            return deferred.promise;
//    //        }
//    //    }

//    //    //return $resource('/DashboardAdmin/USZDashboard/:dashboardId', {dashboardId:'@id'}, {
//    //    //       GetDashboardById: { method: 'GET', params: {}, isArray: false }
//    //    //   });
//    //}]);
//})();