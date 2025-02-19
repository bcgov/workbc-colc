/*global module*/


module.exports = function (grunt) {
  'use strict';

  // Load grunt tasks automatically
  require('load-grunt-tasks')(grunt);
  // grunt.loadTasks('tasks');

  grunt.initConfig({
    pkg: this.file.readJSON('package.json'),

    umdHelper: {
      all: {
        files: [{
          expand: true,
          cwd: 'src/',
          src: ['**/*.js'],
          dest: 'dist/',
          ext: '.js'
        }, ],
        options: {
          namespace: 'hlpz'
        }
      }
    },

    clean: {
      dist: ['dist']
    },

    jshint: {
      options: {
        jshintrc: '.jshintrc'
      },
      all: [
        'Gruntfile.js',
        'src/**/*.js'
      ]
    },

    jsbeautifier: {
      default: {
        src: ['<%= jshint.all %>']
      },
      dist: {
        src: ['dist/**/*.js']
      },
      options: {
        js: {
          braceStyle: 'end-expand',
          indentSize: 2,
          jslintHappy: true,
          // keepFunctionIndentation: true,
          preserveNewlines: true,
          spaceInParen: false
        }
      }
    },

    watch: {
      js: {
        options: {
          livereload: true
        },
        files: ['<%= jshint.all %>'],
        tasks: ['default']
      }
    }
  });

  grunt.registerTask('js', [
    'jsbeautifier:default',
    'jshint'
  ]);

  grunt.registerTask('dev', [
    'default',
    'watch'
  ]);

  grunt.registerTask('build', [
    'clean:dist',
    'umdHelper',
    'jsbeautifier:dist'
  ]);

  return this.registerTask('default', ['js', 'build']);
};
