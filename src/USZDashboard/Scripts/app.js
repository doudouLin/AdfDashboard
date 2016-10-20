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
                            '<div><adf-dashboard name="dashboard" editable="{{sample.editable}}" collapsible="{{sample.collapsible}}" maximizable="{{sample.maximizable}}" categories="{{sample.categories}}" structure="4-8" adf-model="sample.model" /></div><div class="footer"><button class="btn btn-warning" ng-click="sample.SaveDashboard()"><span class="glyphicon glyphicon-remove"></span> Save</button></div>',
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
                    },
                    Save: function(data) {
                        var deferred = $q.defer();
                        $http.post('/DashboardAdmin/USZDashboard', data)
                            .success(function(data){
                                deferred.resolve();
                            })
                            .error(function(){
                                deferred.reject();
                            });
                        return deferred.promise;
                    },
                    SaveWidgets:function(data) {
                        var deferred = $q.defer();
                        $http.post('/DashboardAdmin/USZDashboard/SaveWidgets', data)
                            .success(function (data) {
                                deferred.resolve();
                            })
                            .error(function () {
                                deferred.reject();
                            });
                        return deferred.promise;
                    },
                    AddWidget: function(data) {
                        var deferred = $q.defer();
                        $http.put('/DashboardAdmin/USZDashboard/AddWidget', data)
                            .success(function (data) {
                                deferred.resolve();
                            })
                            .error(function () {
                                deferred.reject();
                            });
                        return deferred.promise;
                    },
                    DeleteWidget: function (id) {
                        var deferred = $q.defer();
                        $http.delete('/DashboardAdmin/USZDashboard/DeleteWidget/'+id)
                            .success(function (data) {
                                deferred.resolve();
                            })
                            .error(function () {
                                deferred.reject();
                            });
                        return deferred.promise;
                    }
                };
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

    AppCtrl.$inject = ['$scope', '$rootScope', '$location', '$routeParams', 'dashboardsFactory', 'dashboardInfo', '$route'];

    function AppCtrl($scope, $rootScope, $location, $routeParams, dashboardsFactory, dashboardInfo, $route) {
        this.name = $routeParams.id;
        this.collapsible = dashboardInfo.collapsible;
        this.maximizable = dashboardInfo.maximizable;
        this.categories = dashboardInfo.categories;
        this.editable = dashboardInfo.editable;
        this.name = dashboardInfo.dashboardName;

        var rows = [];
        console.log(dashboardInfo);
        angular.forEach(dashboardInfo.tableRows, function(tr, index) {
                var columns = [];
                angular.forEach(tr.tableColumns, function (tc, index) {
                    var widgets = [];
                    angular.forEach(tc.widgets, function (wg, index) {
                        var widget = {
                            fullScreen: wg.fullScreen,
                            modalSize: wg.modalSize,
                            type: wg.type,
                            id:wg.id,
                            config: {
                                timePattern: 'HH:mm:ss',
                                datePattern: 'YYYY-MM-DD'
                            },
                            title: wg.title,
                            index: wg.index
                        };
                        widgets.push(widget);
                    });

                    var column = {
                        styleClass: tc.columnStyle,
                        widgets: widgets,
                        id:tc.id
                    };

                    columns.push(column);
                });

                var rowItem = {
                    columns: columns,
                    id: tr.id
                };
                rows.push(rowItem);
            }
        );

        //console.log('have I set Ids?');
        //console.log(rows);
        var model = {
            title: dashboardInfo.title,
            structure: dashboardInfo.structure.value,
            rows: rows
        };

        this.model = model;
        
        //this.SaveDashboard = function() {

        //    if (angular.isDefined(this.model)) {
        //        var tableRows = [];
        //        angular.forEach(this.model.rows, function (tr, trIdx) {
        //            var tableColumns = [];
        //            angular.forEach(tr.columns, function (tc, tcIdx) {
        //                var widgets = [];
        //                angular.forEach(tc.widgets, function (wg, wgIdx) {
        //                    var widget = {
        //                        fullScreen: wg.fullScreen,
        //                        modalSize: wg.modalSize,
        //                        type: wg.type,
        //                        //config: {
        //                        //    timePattern: 'HH:mm:ss',
        //                        //    datePattern: 'YYYY-MM-DD'
        //                        //},
        //                        title: wg.title,
        //                        id: wg.id
        //                    };
        //                    widgets.push(widget);
        //                });

        //                var column = {
        //                    columnStyle: tc.styleClass,
        //                    widgets: widgets,
        //                    id: tc.id
        //                };
        //                tableColumns.push(column);
        //            });

        //            var rowItem = {
        //                id: tr.id,
        //                tableColumns: tableColumns
        //            };
        //            tableRows.push(rowItem);
        //        });

        //        var dashboard = {
        //            id: dashboardInfo.id,
        //            dashboardName: this.model.title,
        //            title: this.model.title,
        //            editable: this.editable,
        //            collapsible: this.collapsible,
        //            maximizable: this.maximizable,
        //            categories: this.categories,
        //            structureId: dashboardInfo.structure.id,
        //            structure: {
        //                structureId: dashboardInfo.structure.id,
        //                value:this.model.structure
        //            },
        //            tableRows: tableRows
        //        }

        //        console.log(dashboard);
        //        dashboardsFactory.Save(dashboard);
        //    }
        //}

        var eventFired = function (event, name, model) {
        };

        var widgetRemovedFromColumnEventFired = function (event, name, model, column, widget) {
            //console.log(event);
            //console.log(name);
            //console.log(model);
            //console.log(column);
            //console.log(widget);
            var index = column.widgets.indexOf(widget);
            dashboardsFactory.DeleteWidget(widget.id);

            updateFollowedWidgets(column, index + 1, -1);
        };

        var widgetMovedInColumnEventFired = function (event, name, model, column, widget) {
            console.log('hihi I am moved');
            updateFollowedWidgets(column, 0, 1);
        };

        var widgetAddedToColumnEventFired = function (event, name, model, column, widget) {
            var index = column.widgets.indexOf(widget);
            dashboardsFactory.AddWidget(widget);

            updateFollowedWidgets(column, index + 1, 1);
        };

        var widgetAddEventFired = function (event, name, model, column, widget) {
            //save new widget to db
            var index = column.widgets.indexOf(widget);

            var newWg = {
                index: index++,
                tableColumnId: column.id,
                title: widget.type,
                fullScreen: false,
                modalSize: 'lg',
                type: widget.type,
                widgetConfigrations: []
            }

            angular.forEach(widget.config, function (value, key) {
                newWg.widgetConfigrations.push({value:value, key:key});
            });
            dashboardsFactory.AddWidget(newWg);

            //update other following widgets' index in column
            updateFollowedWidgets(column, index, 1);
        };

        function updateFollowedWidgets(column, index, increment) {
            //update other following widgets' index in column
            var widgetsToSave = column.widgets.slice(index);
            angular.forEach(widgetsToSave, function (wgToSave, idx) {
                wgToSave.index = index;
                wgToSave.tableColumnId = column.id;
                index = index + increment;
            });
            console.log(widgetsToSave);
            dashboardsFactory.SaveWidgets(widgetsToSave);
        }

        $scope.$on('adfDashboardChanged', eventFired);
        $scope.$on('adfWidgetAdded', widgetAddEventFired);
        $scope.$on('adfWidgetAddedToColumn', widgetAddedToColumnEventFired);
        $scope.$on('adfWidgetRemovedFromColumn', widgetRemovedFromColumnEventFired);
        $scope.$on('adfWidgetMovedInColumn', widgetMovedInColumnEventFired);
    }


