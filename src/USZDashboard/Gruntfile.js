module.exports = function (grunt) {
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-contrib-copy');

    grunt.initConfig({
        uglify: {
            my_target: {
                files: { 'wwwroot/app.js': ['Scripts/app.js', 'Scripts/**/*.js'] }
            }
        },

        copy: {
            main: {
                files: [{
                    expand: true,
                    flatten: true,
                    src: [
                        'Scripts/Css/*.css',
                        'Scripts/Resource/*.gif'
                    ],
                    dest: 'wwwroot/Css/',
                    filter: 'isFile'
                }]
            }
        },

        watch: {
            scripts: {
                files: ['Scripts/**/*.js'],
                tasks: ['uglify', 'copy']
            }
        }
    });

    grunt.registerTask('default', ['uglify', 'copy', 'watch']);
};