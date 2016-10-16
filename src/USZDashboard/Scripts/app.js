(function () {
    'use strict';

    angular.module('DashboardAdmin', [
        // Angular modules 
        'adf',
        'adf.structures.base',
        'adf.widget.clock',
        'LocalStorageModule',
        'DashboardService',
        //'Sample',
        'ngRoute'


        // Custom modules 

        // 3rd Party Modules

    ])
      .value('adfTemplatePath', '../src/templates/')
      .value('rowTemplate', '<adf-dashboard-row row="row" adf-model="adfModel" options="options" edit-mode="editMode" ng-repeat="row in column.rows" />')
      .value('columnTemplate', '<adf-dashboard-column column="column" adf-model="adfModel" options="options" edit-mode="editMode" ng-repeat="column in row.columns" />')
    .config(['$routeProvider', function ($routeProvider) {
        //dashboardProvider.widgetsPath('widgets/');
        //localStorageServiceProvider.setPrefix('adf');

        $routeProvider.when('/sample', {
            templateUrl: '~/Views/Home/Sample.html',
            controller: 'sampleCtrl'
        })
        .otherwise({
            redirectTo: '/sample'
        });

    }]);
    //.config(['$stateProvider', function ($stateProvider) {
    //    $stateProvider
    //      .state("dashboards", {
    //          url: "/DashboardAdmin/USZDashboard",
    //          templateUrl: 'Index.cshtml',
    //          resolve: {
    //              // A string value resolves to a service
    //              DashboardsFactory: 'DashboardsFactory',

    //              // A function value resolves to the return
    //              // value of the function
    //              Dashboards: function (DashboardsFactory) {
    //                  return DashboardsFactory.query();
    //              }
    //          },
    //          controller: 'DashboardController'
    //      });
    //}]);
})();