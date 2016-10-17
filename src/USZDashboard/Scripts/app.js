    'use strict';

    angular.module('DashboardAdmin',
        [
            'adf',
            'ngRoute',
            'adf.structures.base',
            'adf.widget.clock'
        ])
        .value('adfTemplatePath', '../src/templates/')
        .value('rowTemplate',
            '<adf-dashboard-row row="row" adf-model="adfModel" options="options" edit-mode="editMode" ng-repeat="row in column.rows" />')
        .value('columnTemplate',
            '<adf-dashboard-column column="column" adf-model="adfModel" options="options" edit-mode="editMode" ng-repeat="column in row.columns" />')
        .config(['$routeProvider', function ($routeProvider) {
                $routeProvider
                    .when('/samples/:id',
                    {
                        template:
                            '<adf-dashboard name="{{sample.name}}" collapsible="{{sample.collapsible}}" maximizable="{{sample.maximizable}}" categories="{{sample.categories}}" structure="4-8" adf-model="sample.model" />',
                        controller: 'sampleCtrl',
                        controllerAs: 'sample',
                        resolve: {
                            dashboardInfo: ['$route', 'dashboardsFactory', function ($route, dashboardsFactory) {
                                //console.log($route.current.params.id);
                                return dashboardsFactory.GetDashboardById($route.current.params.id);
                            }]
                        }
                    })
                    .otherwise({
                        redirectTo: '/samples'
                    });
            }
        ])
        .service('dashboardsFactory', ['$http', '$q', function ($http, $q) {
                return {
                    GetDashboardById: function(id) {
                        var deferred = $q.defer();
                        $http.get('/DashboardAdmin/USZDashboard/' + id)
                            .success(function(data) {
                                deferred.resolve(data);
                            })
                            .error(function() {
                                deferred.reject();
                            });
                        return deferred.promise;
                    },
                    GetAllDashboards: function() {
                        var deferred = $q.defer();
                        $http.get('/DashboardAdmin/USZDashboard')
                            .success(function(data) {
                                deferred.resolve(data);
                            })
                            .error(function() {
                                deferred.reject();
                            });
                        return deferred.promise;
                    }
                };
                //return $resource('/DashboardAdmin/USZDashboard/:dashboardId', {dashboardId:'@id'}, {
                //       GetDashboardById: { method: 'GET', params: {}, isArray: false }
                //   });
            }
        ])
        .controller('DashboardController',
        [
            '$scope', 'dashboardsFactory', function($scope, dashboardsFactory) {
                var nav = this;

                dashboardsFactory.GetAllDashboards()
                    .then(function(data) {
                        nav.items = data;
                    });

                $scope.$on('navChanged',
                    function() {
                        dashboardsFactory.GetAllDashboards()
                            .then(function(data) {
                                nav.items = data;
                            });
                    });
            }
        ]);

    angular.module('DashboardAdmin').controller('sampleCtrl', AppCtrl);

    AppCtrl.$inject = ['$scope', '$rootScope', '$location', '$routeParams', 'dashboardsFactory', 'dashboardInfo'];

    function AppCtrl($scope, $rootScope, $location, $routeParams, dashboardsFactory, dashboardInfo) {
        console.log(dashboardInfo.title);
        console.log(dashboardInfo.structure);

        this.name = $routeParams.id;
        this.collapsible = dashboardInfo.collapsible;
        this.maximizable = dashboardInfo.maximizable;
        this.categories = dashboardInfo.categories;

        var model = {
            title: dashboardInfo.title,
            structure: dashboardInfo.structure,
            rows: [{
                columns: [{
                    styleClass: "col-md-4",
                    widgets: [{
                        fullScreen: false,
                        modalSize: 'lg',
                        type: "clock",
                        config: {
                            timePattern: 'HH:mm:ss',
                            datePattern: 'YYYY-MM-DD'
                        },
                        title: "AHAHAH"
                    }]
                }, {
                    styleClass: "col-md-8",
                    widgets: [{
                        fullScreen: false,
                        modalSize: 'sm',
                        type: "clock",
                        config: {
                            timePattern: 'HH:mm:ss',
                            datePattern: 'YYYY-MM-DD'
                        },
                        title: "Github Author"
                    }, {
                        fullScreen: true,
                        //modalSize: 'lg',
                        type: "clock",
                        config: {
                            timePattern: 'HH:mm:ss',
                            datePattern: 'YYYY-MM-DD'
                        },
                        title: "Github History"
                    }]
                }]
            }]
        };

        this.model = model;
        
        var eventFired = function (event, name, model) {
            console.log(event);
        };

        var widgetAddeventFired = function (event, name, model, widget) {
            console.log(widget);
            console.log(model);
        };

        $scope.$on('adfDashboardChanged', eventFired);
        $scope.$on('adfWidgetAdded', widgetAddeventFired);
        $scope.$on('adfWidgetMoved', eventFired);
        $scope.$on('adfWidgetAddedToColumn', eventFired);
        $scope.$on('adfWidgetRemovedFromColumn', eventFired);
        $scope.$on('adfWidgetMovedInColumn', eventFired);
    }











    //.config(['$stateProvider', function ($stateProvider) {
    //    $stateProvider
    //      .state("dashboards", {
    //          url: "/DashboardAdmin/USZDashboard",
    //          templateUrl: 'Index.cshtml',
    //          resolve: {
    //              // A string value resolves to a service
//              dashboardsFactory: 'dashboardsFactory',

    //              // A function value resolves to the return
    //              // value of the function
//              Dashboards: function (dashboardsFactory) {
//                  return dashboardsFactory.query();
    //              }
    //          },
    //          controller: 'DashboardController'
    //      });
    //}]);
